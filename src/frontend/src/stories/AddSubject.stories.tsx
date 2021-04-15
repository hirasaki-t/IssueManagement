import { Meta, Story } from "@storybook/react/types-6-0";
import AddSubject from "../components/AddSubject";

export default {
    title: "components/AddSubject",
    components: AddSubject,
} as Meta;

const Template: Story = () => <AddSubject />;

export const Default = Template.bind({});