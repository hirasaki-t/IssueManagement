import { Meta, Story } from "@storybook/react/types-6-0";
import ArchiveListTable from "../components/ArchiveListTable";

export default {
    title: "components/ArchiveListTable",
    components: ArchiveListTable,
} as Meta;

const Template: Story = () => <ArchiveListTable />;

export const Default = Template.bind({});