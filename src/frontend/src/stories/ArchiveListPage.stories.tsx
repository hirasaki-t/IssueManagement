import { Meta, Story } from "@storybook/react/types-6-0";
import ArchiveListPage from "../pages/ArchiveListPage";

export default {
    title: "pages/ArchiveListPage",
    components: ArchiveListPage,
} as Meta;

const Template: Story = () => <ArchiveListPage />;

export const Default = Template.bind({});